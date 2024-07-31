using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Demo1.ActionFilters
{
    public class MyExceptionHandeller:ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception != null)
            {
                context.ExceptionHandled = true;

                context.Result = new ContentResult() {Content = "Contact with Adminstrator"};
            }
            base.OnActionExecuted(context);
        }
    }
}
