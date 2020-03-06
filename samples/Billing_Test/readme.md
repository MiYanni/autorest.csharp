# Billing
### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
title: Billing
require:
  - $(this-folder)/../readme.samples.md
#  - https://github.com/Azure/azure-rest-api-specs/blob/resource-hybrid-profile/specification/billing/resource-manager/readme.md
#  - https://github.com/Azure/azure-rest-api-specs/blob/resource-hybrid-profile/specification/commerce/resource-manager/readme.md
#  - https://github.com/Azure/azure-rest-api-specs/blob/resource-hybrid-profile/specification/consumption/resource-manager/readme.md
#profile: latest-2019-04-30
input-file:
  - https://github.com/Azure/azure-rest-api-specs/blob/resource-hybrid-profile/specification/billing/resource-manager/Microsoft.Billing/preview/2019-10-01-preview/billing.json
  - https://github.com/Azure/azure-rest-api-specs/blob/resource-hybrid-profile/specification/commerce/resource-manager/Microsoft.Commerce/preview/2015-06-01-preview/commerce.json
  - https://github.com/Azure/azure-rest-api-specs/blob/resource-hybrid-profile/specification/consumption/resource-manager/Microsoft.Consumption/stable/2019-06-01/consumption.json
namespace: Azure.Billing
```