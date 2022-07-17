## 📚 Pokémon CRUD

This repository was developed to learn how to create a CRUD in C# in version 5.0 of .NET using clean architecture following the playlist <i><a>https://www.youtube.com/playlist?list=PLbq2QKd5ieAt0H551D_0E4bGIYRxbq5HL</a></i> by Francis Silveira Andrade on YouTube

## 📫  Routes

**GET**  — "/api/Pokemons"

_Get all Pokemons_

response:

```
[
  {
     "id": int,
	 "tipo": string,
	 "nome": string,
	 "poder": double,
	 "dataCriacao"?: DateTime,
	 "dataAtualizacao"?: DateTime
  }
]
```

<hr>

**POST**  — "/api/Pokemons"

_Create a new Pokemon_

body:

```
{
   "tipo": string,
   "nome": string,
   "poder": double 
}
```

response:

```
{
   "id": int,
   "tipo": string,
   "nome": string,
   "poder": double,
   "dataCriacao": DateTime,
   "dataAtualizacao": null
}
```

<hr>

**PUT**  — "/api/Pokemons"

_Update an existing Pokemon by your id_

body:

```
{
   "tipo": string,
   "nome": string,
   "poder": double,
   "id": int
}
```

response:

```
{
   "id": int,
   "tipo": string,
   "nome": string,
   "poder": double,
   "dataCriacao": DateTime,
   "dataAtualizacao": DateTime
}
```

<hr>

**GET**  — "/api/Pokemons/{ id }"

_Get a specific Pokemon by your id_

route params:

`id: int`


response:

```
{
   "id": int,
   "tipo": string,
   "nome": string,
   "poder": double,
   "dataCriacao": DateTime,
   "dataAtualizacao"?: DateTime
}
```

<hr>

**DELETE**  — "/api/Pokemons/{ id }"

_Delete a Pokemon by your id_

route params:

`id: int`

## 🌐 Status
<p>Finished project ✅</p>

## 🧰 Prerequisites

.NET 5.0

<p>Connection string to SQL Server BD in app-charp/AP.Api/appsettings.json named as "APConnection"</p>

## 🔧 Installation
`$ git clone https://github.com/AllanDutra/pokemon-crud.git`

`$ cd pokemon-crud/AP.Api`

`$ dotnet ef database update -p ../AP.Data/AP.Data.csproj -s ./AP.Api.csproj`

`$ dotnet run`

**Server listenning at  [https://localhost:5001/](http://localhost:3333/)!**

## 🔨 Tools used

<div>
<img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" width="80" /> 
<img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg" width="80" />
<img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/microsoftsqlserver/microsoftsqlserver-plain.svg" width="80" />

</div>
