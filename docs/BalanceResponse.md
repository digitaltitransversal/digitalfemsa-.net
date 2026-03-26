# DigitalFemsa.net.Model.BalanceResponse
Company balance summary.  Monetary fields are returned as arrays of amounts grouped by currency (see `balance_common_field` items). 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Available** | [**List&lt;BalanceCommonField&gt;**](BalanceCommonField.md) | Amounts currently available, grouped by currency. | [optional] 
**CashoutRetentionAmount** | [**List&lt;BalanceCommonField&gt;**](BalanceCommonField.md) | The balance&#39;s cashout retention amount | [optional] 
**ConektaRetention** | [**List&lt;BalanceCommonField&gt;**](BalanceCommonField.md) | The balance&#39;s Femsa retention | [optional] 
**Gateway** | [**List&lt;BalanceCommonField&gt;**](BalanceCommonField.md) | Gateway balance amounts, grouped by currency. | [optional] 
**Pending** | [**List&lt;BalanceCommonField&gt;**](BalanceCommonField.md) | Amounts pending settlement, grouped by currency. | [optional] 
**Retained** | [**List&lt;BalanceCommonField&gt;**](BalanceCommonField.md) | Amounts currently retained, grouped by currency. | [optional] 
**RetentionAmount** | [**List&lt;BalanceCommonField&gt;**](BalanceCommonField.md) | Retention amount applied, grouped by currency. | [optional] 
**TargetCollateralAmount** | **Object** | Target collateral amount, grouped by currency. | [optional] 
**TargetRetentionAmount** | [**List&lt;BalanceCommonField&gt;**](BalanceCommonField.md) | Target retention amount, grouped by currency. | [optional] 
**TemporarilyRetained** | [**List&lt;BalanceCommonField&gt;**](BalanceCommonField.md) | Amounts temporarily retained | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

