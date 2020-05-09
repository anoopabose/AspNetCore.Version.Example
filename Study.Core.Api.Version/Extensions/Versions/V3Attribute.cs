using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace  Study.Core.Api.Version.Extensions.Versions
{

    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed class V3Attribute : ApiVersionAttribute
    {
        public V3Attribute() : base(new ApiVersion(new DateTime(2019, 01, 01))) { }
    }
}
