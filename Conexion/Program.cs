
using Conexion.Domain.DbContexto;
using Conexion.Repository;
using Conexion.Services.IServices;
using Conexion.Services.Services;

//using Conexion.Services.Services;
using DocumentFormat.OpenXml.Bibliography;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Text.Json.Serialization;



var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SysIturanContext>(
	options =>
	{
		options.UseSqlServer(builder.Configuration.GetConnectionString("dev"));
	});



builder.Services.AddSwaggerGen(c =>
{
	c.SwaggerDoc("v1", new OpenApiInfo
	{
		Title = "Api REST Connection ",
		Version = "v2.0.0",

		Contact = new OpenApiContact
		{
			Name = "Victor Uriel Aviles Alvarez",
			Email = "uvictoraviles43@gmail.com",
		},

	});
	var securitySchema = new OpenApiSecurityScheme
	{
		Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
		Name = "Authorization",
		In = ParameterLocation.Header,
		Type = SecuritySchemeType.Http,
		Scheme = "bearer",
		Reference = new OpenApiReference
		{
			Type = ReferenceType.SecurityScheme,
			Id = "Bearer"
		}
	};
	c.AddSecurityDefinition("Bearer", securitySchema);
	var securityRequirement = new OpenApiSecurityRequirement
	{
		{securitySchema, new [] {"Bearer"} }
	};
	c.AddSecurityRequirement(securityRequirement);
});


JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
builder.Services
	.AddAuthentication(options =>
	{
		options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
		options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
		options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
	})
	.AddJwtBearer(cfg =>
	{
		cfg.RequireHttpsMetadata = false;
		cfg.SaveToken = true;
		cfg.TokenValidationParameters = new TokenValidationParameters
		{
			ValidIssuer = builder.Configuration["JwtIssuer"],
			ValidAudience = builder.Configuration["JwtIssuer"],
			IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtKey"])),
			ClockSkew = TimeSpan.Zero // remove delay of token when expire
		};
	});




builder.Services.AddControllers().AddJsonOptions(x =>
		   x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);
object p = builder.Services.AddControllers().AddNewtonsoftJson(x =>
 x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
// Add services to the container.

builder.Services.AddControllers();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle





builder.Services.AddScoped<IWeebhook, WeebHookServices>();
builder.Services.AddScoped<WebhookRepository>();




var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
	app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Connection.Web v1"));
}
app.UseDeveloperExceptionPage();
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Connection.Web v1"));


// Configure the HTTP request pipeline.

app.UseCors(options =>
{

	options.AllowAnyMethod();
	options.AllowAnyHeader();
	options.SetIsOriginAllowed(origin => true);
	options.AllowCredentials();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


