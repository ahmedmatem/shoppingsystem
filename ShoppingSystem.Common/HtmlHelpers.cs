namespace ShoppingSystem.Common
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.Routing;

    public static class HtmlHelpers
    {
        public static string IsSelected(this HtmlHelper html, string controllers = "", string actions = "", string cssClass = "selected")
        {
            controllers = controllers.ToLower();
            actions = actions.ToLower();

            ViewContext viewContext = html.ViewContext;
            bool isChildAction = viewContext.Controller.ControllerContext.IsChildAction;

            if (isChildAction)
                viewContext = html.ViewContext.ParentActionViewContext;

            RouteValueDictionary routeValues = viewContext.RouteData.Values;
            string currentAction = routeValues["action"].ToString().ToLower();
            string currentController = routeValues["controller"].ToString().ToLower();

            if (String.IsNullOrEmpty(actions))
                actions = currentAction.ToLower();

            if (String.IsNullOrEmpty(controllers))
                controllers = currentController.ToLower();

            string[] acceptedActions = actions.Trim().Split(',').Distinct().ToArray();
            string[] acceptedControllers = controllers.Trim().Split(',').Distinct().ToArray();

            var isSelected = acceptedActions.Contains(currentAction) && acceptedControllers.Contains(currentController) ?
                cssClass : String.Empty;

            return isSelected;
        }
    }
}