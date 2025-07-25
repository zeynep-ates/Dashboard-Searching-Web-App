# Dashboard Searching Web App

This is an ASP.NET Core Razor Pages web application that allows users to search and locate telemetry data across Grafana dashboards using UID values. The project interacts with Grafana's HTTP API, retrieves dashboard JSON structures, and parses them to locate panels containing the target telemetry.

## Project Background

This project was developed as part of an internship where Grafana was used to visualize data received from satellites. Satellites have many parts, and each part can emit dozens or even hundreds of telemetry values. These telemetry values are used in multiple panels and dashboards.

When a telemetry value changes or becomes invalid, manually locating every panel that contains it is highly time-consuming. This application solves that problem by letting researchers input a telemetry UID and automatically retrieve all related panels across dashboards.

Additionally, users can also search by **telemetry name**, even if they don't know the full name or exact ID. This significantly improves research efficiency by removing manual inspection steps.

## Features

- Fetch dashboards via Grafana HTTP API using UID
- Parse dashboard JSON to locate panels with given telemetry ID
- Fuzzy search for telemetry names (no need to know full names)
- Displays matched panels to the user in a clean interface
- UID list is managed via external config (`appsettings.json`)

## Technologies Used

- ASP.NET Core (.NET 6)
- Razor Pages
- C#
- Web Service Reference (`ZeynepWsClient`)
- JSON parsing and filtering
- Configuration via `appsettings.json` (ignored by git)
