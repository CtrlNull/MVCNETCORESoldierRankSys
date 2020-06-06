#### MVC .NET Core 3.1 Interview Exercise

## Docker Sql Server Setup

[Docker SqlServer setup instructions](https://docs.microsoft.com/en-us/sql/linux/quickstart-install-connect-docker?view=sql-server-ver15&pivots=cs1-bash)

~~~
sudo docker exec -it sql1 /opt/mssql-tools/bin/sqlcmd \
   -S localhost -U SA -P "<YourStrong@Passw0rd>" \
   -Q 'ALTER LOGIN SA WITH PASSWORD="<YourNewStrong@Passw0rd>"'
~~~

~~~
/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "<P@$$w0Rd>"
~~~

## Docker MVC Setup

[Dockerize Core app instructions](https://hub.packtpub.com/how-to-dockerize-asp-net-core-application/)

## Solution Files
 
 1) SQL folder - containes scrips loaded for generating table and/or data


## NugetPackages

June, 5th 2020
Microsoft.EntityFrameworkCore.SqlServer 3.4.1