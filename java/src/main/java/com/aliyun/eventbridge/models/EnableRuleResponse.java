// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.eventbridge.models;

import com.aliyun.tea.*;

/**
 * The response of enable the EventBus rule
 */
public class EnableRuleResponse extends TeaModel {
    @NameInMap("RequestId")
    @Validation(required = true)
    public String requestId;

    @NameInMap("ResourceOwnerAccountId")
    @Validation(required = true)
    public String resourceOwnerAccountId;

    public static EnableRuleResponse build(java.util.Map<String, ?> map) {
        EnableRuleResponse self = new EnableRuleResponse();
        return TeaModel.build(map, self);
    }

    public EnableRuleResponse setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public EnableRuleResponse setResourceOwnerAccountId(String resourceOwnerAccountId) {
        this.resourceOwnerAccountId = resourceOwnerAccountId;
        return this;
    }
    public String getResourceOwnerAccountId() {
        return this.resourceOwnerAccountId;
    }

}
