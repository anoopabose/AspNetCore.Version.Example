using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Study.Core.Api.Version.Extensions.Versions
{

  [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
  public sealed class V1Attribute : ApiVersionAttribute
  {
    public V1Attribute() : base(new ApiVersion(new DateTime(2016, 7, 1))) {
        this.Deprecated = true;
     }
  }
}
