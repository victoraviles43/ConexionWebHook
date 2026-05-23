# Solución Webhook


## Solución

La solución que doy es separar la recepción del webhook del procesamiento pesado. En lugar de procesar directamente el ERP y CRM dentro del endpoint, ahora únicamente recibe la información, valida los datos y guarda cada registro en la base de datos con un estado inicial de `Pendiente`.

Después de guardar los datos, el API responde inmediatamente con un `200 OK`, evitando timeouts y pérdida de eventos.

Posteriormente, un `BackgroundService` en .NET se encarga de leer los registros pendientes y procesarlos en segundo plano. Este worker envía la información al ERP y CRM, actualizando posteriormente el estado del registro a:

- `Procesado`
- `Error`
- `Reintento`


---

# 

```text
+----------------------+
| Proveedor Webhook    |
+----------+-----------+
           |
           v
+----------------------+
| API .NET Webhook     |
| Controller           |
+----------+-----------+
           |
           v
+----------------------+
| SQL Server           |
| Tabla WebhookEvens   |
+----------+-----------+
           |
           | Status = Pendiente
           v
+----------------------+
| BackgroundService    |
| Worker .NET          |
+----------+-----------+
           |
     +-----+-----+
     |           |
     v           v
+---------+   +---------+
| ERP     |   | CRM     |
|Contrato |   | Usuario |
+----+----+   +----+----+
     |             |
     +------+------+ 
            |
            v
+----------------------+
| Actualizar Status    |
|                      |
| Procesado            |
| Error/Reintento      |
+----------------------+
```

