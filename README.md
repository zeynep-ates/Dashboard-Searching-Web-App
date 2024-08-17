# DashboardSearchingWebApp
This is an ASP.NET Razor Pages project. I did not upload the whole solution but some important parts. It basically calls Grafana HTTP API and gets JSON files of dashboards by their uIDs. Then, it gets input from the user and searches through the JSON to give the necessary output.

I worked on this project in my internship. The organization uses Grafana to visualize the data from satellites. There are lots of parts of satellites and each part has lots of different telemetries, which means there are hundreds of panels in many dashboards. A telemetry value can be used in multiple panels according to the needs of the researchers. However, suppose a change occurs in the dataset. In that case, it affects all panels with that telemetry and it is unnecessarily time-consuming to search through the panels and look for that one telemetry. With this project, researchers can easily find the panels with that one telemetry by only using the ID. Another feature of the project is that the user can search for a telemetry name if they do not know the ID and the best part is they do not even need to know the full name of the telemetry.

I hid some information in the codes, such as the API key and uID list for security purposes.

