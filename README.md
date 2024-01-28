# Proyecto Ingenería de Software (2022)

Sistema de Gestión de Artículos y Ejemplares de una Editorial: Desarrollo centrado en el Backend con C# y .NET. La interfaz de usuario se implementa mediante Windows Forms.

La arquitectura del sistema sigue una estructura de capas diferenciadas: capa de presentaión, capa de lógica de negocios y la capa de datos (DAL). La lógica de negocio se encapsula en servicios, implementados en la clase MagazineService y la interfaz IMagazineService define los métodos que la capa superior (UI) puede utilizar para interactuar con la lógica de negocio.

La gestión de errores se realiza mediante excepciones, y se ha creado una subclase de Exception llamada ServiceException para reportar errores generados en la capa lógica.
La persistencia de los datos se gestiona a traves de Entity Framework.

Los casos de uso que se van a implementar son los siguientes:

![casos de uso](https://github.com/haitaoo1/Proyecto-Infenieria-Sofware/blob/main/casos%20de%20uso.png)


