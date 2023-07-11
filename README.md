# bodegas-app


# Creación del proyecto

   Cree una Carpeta principal en la cual se crearan los proyectos internos para la generación del WebApi

------



- ​       Ingrese el comando **dotnet new list** para visualizar las plantillas disponibles de .Net
- ​       Ejecute comando **dotnet new sln** : Generar solucion principal.
- ​       Ejecute el comando **dotnet new webapi –-output API : Para crear el proyecto WebApi
- ​       dotnet sln add (Solucion Agregar) ex. dotnet sln add .\API\
- ​       Ejecute el comando : **dotnet new classlib –o Core**

- ​       Ejecute el comando : **dotnet new classlib –o Infrastructure**
- ​       Agregue los proyectos Core e Infrastructure
    ​    ​    dotnet sln add .\Core\
    ​    ​    dotnet sln add .\Infrastructure
- ​      Ejecute el comando : dotnet sln list -> Para visualizar los proyectos agregados a la solucion

------

  ```tex
  Proyectos    
  API\API.csproj
  Core\Core.csproj
  Infrastructure\Infrastructure.csproj
  PS D:\projectsNetCore\bodegas>
  ```

------

- Establezca referencia entre los proyectos Infraestructure y Core (Se debe Ubicar en la carpeta Infrastructure)

  ```tex
  PS D:\projectsNetCore\bodegas> cd .\Infrastructure\
  PS D:\projectsNetCore\bodegas\Infrastructure> dotnet add reference ..\Core\
  Se ha agregado la referencia "..\Core\Core.csproj" al proyecto.
  PS D:\projectsNetCore\bodegas\Infrastructure>
  ```

  Establezca referencia entre Api e Infrastructure

  ```tex
  PS D:\projectsNetCore\bodegas> cd .\API\
  PS D:\projectsNetCore\bodegas\API> dotnet add reference ..\Infrastructure\
  ```


- 
      
   
   
