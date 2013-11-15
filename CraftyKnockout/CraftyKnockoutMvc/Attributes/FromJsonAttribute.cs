namespace CraftyKnockoutMvc.Attributes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Script.Serialization;

    public sealed class FromJsonAttribute : CustomModelBinderAttribute
    {
        private readonly static JavaScriptSerializer serializer = new JavaScriptSerializer();

        public override IModelBinder GetBinder()
        {
            return new JsonModelBinder();
        }

        private class JsonModelBinder : IModelBinder
        {
            public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
            {
                if (bindingContext == null || controllerContext == null)
                {
                    return null;
                }

                var stringified = controllerContext.HttpContext.Request[bindingContext.ModelName];

                if (string.IsNullOrEmpty(stringified))
                {
                    return null;
                }

                return serializer.Deserialize(stringified, bindingContext.ModelType);
            }
        }
    }
}