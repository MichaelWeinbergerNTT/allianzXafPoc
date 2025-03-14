# PoC
## Requirements:

- Lokale Adminrechte
- Lokale Datenbank
- Podman:  https://podman-desktop.io/downloads/windows
  - requires WSL2 + Postgres image: https://www.geeksforgeeks.org/set-up-a-postgresql-database-with-podman/
- or Docker Desktop

### WSL 
- https://pureinfotech.com/set-default-distro-wsl2-windows-10/
- Validate
wsl --list
wsl --set-default-version 2

### Postgres image
- docker run --name postgres -d -p 5432:5432 -e POSTGRES_USER=postgres -e POSTGRES_DB=db -e POSTGRES_PASSWORD=postgres postgres:latest
- https://www.geeksforgeeks.org/set-up-a-postgresql-database-with-podman/

### Data manipulation

- PGadmin: https://www.pgadmin.org/download/pgadmin-4-windows/
- dbBeaver: https://dbeaver.io/download/

### DevExpress

- Lizenzen Remote:
  
NuGet Feed URL with the DevExpress Universal Subscription von https://nuget.devexpress.com/
https://docs.devexpress.com/GeneralInformation/116042/nuget/obtain-your-nuget-feed-credentials#onlineremote-nuget-feed-from-the-devexpress-server-no-installer

- Local installation:
  
https://www.devexpress.com/Products/Try/

## Examples
- https://docs.devexpress.com/eXpressAppFramework/401943/getting-started/basic-tutorial-blazor
- https://github.com/DevExpress-Examples/xaf-create-multitenant-application
- https://docs.devexpress.com/eXpressAppFramework/112670/expressapp-framework
