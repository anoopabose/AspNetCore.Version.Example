using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace  Study.Core.Api.Version.Extensions.Versions
{

    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed class V2Attribute : ApiVersionAttribute
    {
        public V2Attribute() : base(new ApiVersion(new DateTime(2018, 01, 01))) { }
    }
}
