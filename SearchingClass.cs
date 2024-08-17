namespace DashboardWebApp2
{
    public class SearchingClass
    {
        public string searchResponseText { get; set; }
        GetUidList getUidList = new GetUidList();
        DashboardJson dashboardJson = new DashboardJson();
        public string SearchingID(string userInput)
        {
            List<string> PanelList = new List<string> { };
            if (int.TryParse(userInput, out int a))
            {
                foreach (var uid in getUidList.UidList)
                {
                    dynamic dashboardOutputModel = dashboardJson.getDashboardJson(uid).Result;

                    foreach (var panel in dashboardOutputModel.dashboard.panels)
                    {

                        foreach (var target in panel.targets)
                        {
                            if (target.rawSql.Replace(" ", "").Contains(String.Concat("id=", userInput)))
                            {
                                PanelList.Add(panel.title);
                                string panelUrl = "http://" + dashboardJson.ipAdress + ":3000/d/" + uid + "/" +
                                    dashboardOutputModel.dashboard.title + "?orgId=1&viewPanel=" + panel.id;
                                panelUrl = "<a href='" + panelUrl + "'>url</a>";

                                searchResponseText += "This ID appears in "
                                    + panel.title + ". (Link to panel: "
                                    + panelUrl + ")</br>";
                            }
                        }
                    }
                } 
            }
            else
            {
                PanelList.Add("Telemetry ID is in incorrect form.");
                searchResponseText = "Telemetry ID must be an integer.";
            }
            

            if (PanelList.Count == 0)
            {
                searchResponseText = "This ID does not appear in any panels.";
            }

            return searchResponseText;

        }

        public string SearchingName(string userInput)
        {
            List<string> PanelList = new List<string> { };
            foreach (var uid in getUidList.UidList)
            {
                dynamic dashboardOutputModel = dashboardJson.getDashboardJson(uid).Result;

                foreach (var panel in dashboardOutputModel.dashboard.panels)
                {
                    if (panel.title.Contains(userInput))
                    {
                        PanelList.Add(panel.title);
                        string panelUrl = "http://" + dashboardJson.ipAdress + ":3000/d/" + uid + "/" + dashboardOutputModel.dashboard.title + "?orgId=1&viewPanel=" + panel.id;
                        panelUrl = "<a href='" + panelUrl + "'>url</a>";

                        searchResponseText += "The telemetry you are looking for might be "
                                + panel.title + ". (Link to panel: "
                                + panelUrl + ")</br>";
                    }
                }

            }

            if (PanelList.Count == 0)
            {
                searchResponseText = "This name does not appear in any panels.";
            }

            return searchResponseText;

        }
    }
}
