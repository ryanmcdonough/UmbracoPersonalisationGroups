﻿namespace Zone.UmbracoPersonalisationGroups.Criteria.Querystring
{
    using System.Collections.Specialized;
    using System.Web;

    public class HttpContextQuerystringProvider : IQuerystringProvider
    {
        public NameValueCollection GetQuerystring()
        {
            return HttpContext.Current.Request.QueryString;
        }
    }
}
