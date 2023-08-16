# .NET microservices simple structure example
## Stack
- .NET
- Docker
- Docker Compose
- Envoy gateway

## Abilities
- Run all services with one command
- Debug each .NET microservice
- Repository per project approach

## Installation

Clone repository. Make sure that you have installed docker and docker compose.
Open Infrastructure/Development and run:

```sh
docker compose up
```

This will run all services and envoy gateway.

Open browser and go to 
```sh
localhost:10000/service-one
```
or
```sh
localhost:10000/service-two
```

To debug please open Visual Studio Code in ServiceOne or ServiceTwo folder and attach via F5 or Debug button on UI.

And that's it ✨.