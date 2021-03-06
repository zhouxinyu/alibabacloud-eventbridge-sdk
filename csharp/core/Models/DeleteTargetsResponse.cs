// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EventBridge.Models
{
    /**
     * The response of delete Targets
     */
    public class DeleteTargetsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ResourceOwnerAccountId")]
        [Validation(Required=true)]
        public string ResourceOwnerAccountId { get; set; }

        [NameInMap("ErrorEntriesCount")]
        [Validation(Required=true)]
        public int? ErrorEntriesCount { get; set; }

        [NameInMap("ErrorEntries")]
        [Validation(Required=true)]
        public List<TargetResultEntry> ErrorEntries { get; set; }

    }

}
