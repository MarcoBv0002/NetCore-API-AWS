# NetCore-API-AWS

Este proyecto implementa una aplicación ASP.NET Core utilizando el framework .NET 8 y se integra con servicios de AWS. La solución está diseñada para ser desplegada localmente y también puede ser migrada a un entorno en la nube de AWS utilizando el template.serverless proporcionado.

## Dependencias del Proyecto

- `Microsoft.EntityFrameworkCore.SqlServer`: Para interactuar con una base de datos SQL Server.
- `Microsoft.AspNetCore.Components.QuickGrid.EntityFrameworkCoreAdapter`: Proporciona integración con QuickGrid para la visualización de datos.
- `Amazon.Lambda.AspNetCoreServer.Hosting`: Herramientas para alojar una aplicación ASP.NET Core en AWS Lambda.
- `Amazon.Lambda.AspNetCoreServer`: Bibliotecas necesarias para ejecutar una aplicación ASP.NET Core en AWS Lambda.
- `Microsoft.EntityFrameworkCore.Tools`: Herramientas de línea de comandos para trabajar con Entity Framework Core.
- `Microsoft.VisualStudio.Web.CodeGeneration.Design`: Herramientas de diseño para generar código en proyectos web de ASP.NET Core.
## Despliegue

Puedes ejecutar esta aplicación de varias maneras:

1. **Localmente**: Utiliza Visual Studio 2022 con NET CORE 8 para poder ejecutar la solución.

2. **En la nube de AWS**: Utiliza el template.serverless proporcionado para desplegar la aplicación en AWS. Esto puede ser especialmente útil para escalabilidad y alta disponibilidad.



## Base de Datos

La base de datos utilizada es un motor público alojado en una instancia RDS de SQL Server. Esto proporciona una solución escalable y gestionada para el almacenamiento de datos.

Puedes cambiar la cadena de conexión accediendo a src/CreateCar/appsettings.json


