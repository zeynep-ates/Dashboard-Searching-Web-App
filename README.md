# Dashboard Searching Web App
This is an ASP.NET Razor Pages project. I did not upload the whole solution but some important parts. Basically, it calls Grafana HTTP API and gets JSON files of dashboards by their uIDs. Then, it gets input from the user and searches through the JSON to give the necessary output.

I worked on this project in my internship. The organization uses Grafana to visualize the data from satellites. There are lots of parts of satellites and each part has lots of different telemetries, which means there are hundreds of panels in many dashboards. A telemetry value can be used in multiple panels according to the needs of the researchers. However, suppose a change occurs in the dataset. In that case, it affects all panels with that telemetry and it is unnecessarily time-consuming to search through the panels and look for that one telemetry. With this project, researchers can easily find the panels with that one telemetry by only using the ID. Another feature of the project is that the user can search for a telemetry name if they do not know the ID and the best part is they do not even need to know the full name of the telemetry.

I hid some information in the codes, such as the API key and uID list for security purposes.

_Short explanation of files:_

* DashboardJson.cs: Where the API is called.

* GetUidList.cs: The list of uIDs is retrieved from a dataset in the actual project but it is possible to enter them by hand like this.

* SearchingClass.cs: A class containing the two different searching functions.

* Search.cshtml: Frontend of the page, has a form to get the input.

* Search.cshtml.cs: PageModel of Search, calls the desired function on post.
