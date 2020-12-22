# PersistantState showcase
This is a showcase how to include database support in your apps. **If you include external dependecies you will have to use ether the project or publish options to deploy your apps** See [advanced deployment](https://netdaemon.xyz/docs/started/installation) in the docs.

It uses Entity Framework Core to access the MariaDb to stor key/value states.

## 1. Create the database

Create the database in your maria db and call it `test`

Use your favorite tool to connect to your MariaDb instance. If you use MariaDb on Home Assistant addon, you can just use a configuration like the example below. I add comments where it is added new configurations.

```yaml
databases:
  - ha
  - test                             # added
logins:
  - username: hass
    host: '%'
    password: HomeAssistantHA7
  - username: root
    host: '%'
    password: ''
  - username: test                   # added
    host: '%'                        #
    password: test                   #
rights:
  - username: hass
    host: '%'
    database: ha
    grant: ALL PRIVILEGES ON
  - username: test                   # added
    host: '%'                        #
    database: test                   #
    grant: ALL PRIVILEGES ON         #

```
## 2. Create table

```sql
CREATE TABLE `States` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `PropName` longtext CHARACTER SET utf8mb4 NOT NULL,
    `IntValue` int NULL,
    `StringValue` longtext CHARACTER SET utf8mb4 NULL,
    `DoubleValue` double NULL,
    CONSTRAINT `PK_States` PRIMARY KEY (`Id`)
);
```

## 3. Test the counter
1. Rename `_appsettings.json`->`appsettings.json` and edit `appsettings.json` to connect to your instance of Home Assistant, Host and Token is required
2. Review `connection_string`setting in PersistantStateApp.yaml, edit as needed
3. Now debug/run the apps. Each time it should count the number of times it is initialized.

ATTRIBUTION @quettih (Hermes), provided a sample to I could look at