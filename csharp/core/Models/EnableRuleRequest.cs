// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EventBridge.Models
{
    /**
     * The request of enable the EventBus rule
     */
    public class EnableRuleRequest : TeaModel {
        [NameInMap("EventBusName")]
        [Validation(Required=true)]
        public string EventBusName { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=true)]
        public string RuleName { get; set; }

    }

}
