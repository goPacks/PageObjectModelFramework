Feature: PMT

A short summary of the feature

@PaymentPortal
Scenario: 1.Automatic Balance Transfer from Tax Arrears
	Given I navigate to TpPortal at @"https://tpportal-mtra.intranet.pajak.go.id"
	Then  I will enter "1091031210910452" as TIN and "VOTAqg2zRCX5hQxK" as Password
	And   I will click on Login Button
	When  I am on page titled "Registration Portal"
	When  I click on Portal Home Menu label "Payment" 
	When  I click on Portal Home SubMenu label "Tax Arrears Billing Code"
	Then  I will AutoBalTransferFromTaxArrears on Portal Payment Page

	
@PaymentCore
Scenario: 2.Automatic Balance Transfer from Tax Return
	Given I navigate to CtasCore at @"https://ctas-mtra.intranet.pajak.go.id/home/en-US/"
	Then  I enter "wahyu.agungsugimartanto" as userId and "Pajak123" as Password
	Then  I press Login Button
	When  I am on page titled "Home"
	Then  I click on Core Home Menu label "Payment"
	Then  I click on Core Home SubMenu label "Balance Transfer Request"
	When  I am on page titled "Payment"
	Then  I click on Create New Balance Transfer Request menu
	Then  I enter New Request = "CL009871" and NPWP = "1091031210910452" on  New Balance Transfer Request Details Form
	Given I move to CtasCore at @"https://ctas-mtra.intranet.pajak.go.id/home/en-US/"
	Then  I enter "wahyu.agungsugimartanto" as userId and "Pajak123" as Password
	Then  I press Login Button
	When  I am on page titled "Home"
	Then  I click on Core Home Menu label "Payment"
	Then  I click on Core Home SubMenu label "Balance Transfer Request"
	When  I am on page titled "Payment"
	And   I will check on Balance Transfer Request success

		
@PaymentCore
Scenario: 3. Balance Transfer Reallocation Request Monitoring
	Given I navigate to CtasCore at @"https://ctas-mtra.intranet.pajak.go.id/home/en-US/"
	Then  I enter "wahyu.agungsugimartanto" as userId and "Pajak123" as Password
	Then  I press Login Button
	When  I am on page titled "Home"
	Then  I click on Core Home Menu label "Reports"
	Then  I click on Core Home SubMenu label "Balance Transfer Reallocation Request Monitoring"


@PaymentPortal
Scenario: 4.Creation of billing code from Tax Return (portal)
	Given I navigate to TpPortal at @"https://tpportal-mtra.intranet.pajak.go.id"
	Then  I will enter "1091031210910452" as TIN and "VOTAqg2zRCX5hQxK" as Password
	And   I will click on Login Button
	When  I am on page titled "Registration Portal"
	When  I click on Portal Home Menu label "eBUPOT (Withholding Slips)" 
	When  I click on Portal Home SubMenu label "BPU"
	Then  I will perform CcreationOfBillingcodeFromTaxReturnPortal wth TIN = "1091031210910452" on Portal Withholding page
	
@PaymentCore
	Scenario: 5.Monitoring for Overpayment and Interest Compensation
	Given I navigate to CtasCore at @"https://ctas-mtra.intranet.pajak.go.id/home/en-US/"
	Then  I enter "wahyu.agungsugimartanto" as userId and "Pajak123" as Password
	Then  I press Login Button
	When  I am on page titled "Home"
	Then  I click on Core Home Menu label "Reports"
	Then  I click on Core Home SubMenu label "Monitoring for Overpayment and Interest Compensation"


@PaymentCore
	Scenario: 6.Monitoring for Payment Data
	Given I navigate to CtasCore at @"https://ctas-mtra.intranet.pajak.go.id/home/en-US/"
	Then  I enter "wahyu.agungsugimartanto" as userId and "Pajak123" as Password
	Then  I press Login Button
	When  I am on page titled "Home"
	Then  I click on Core Home Menu label "Reports"
	Then  I click on Core Home SubMenu label "Monitoring for Payment Data"

	
	
	#
#
#	@PaymentPortal
#Scenario: 9.Automatic Balance Transfer from Tax Return
#	Given I navigate to TpPortal at @"https://tpportal-mtra.intranet.pajak.go.id"
#	Then  I will enter "1091031210910452" as TIN and "VOTAqg2zRCX5hQxK" as Password
#	And   I will click on Login Button
#	When  I am on page titled "Registration Portal"
#	When  I click on Portal Home Menu label "eBUPOT (Withholding Slips)" 
#	When  I click on Portal Home SubMenu label "BPU"
#	When  I am on page titled "WithholdingPortal"
#	Then  I will perform eBupot BPU wth TIN = "1091031210910452" on Portal Withholding page
#
#
##@PaymentCore
#    Scenario:Self Service Billing Code Creation
#	Given I navigate to CtasCore at @"https://ctas-mtra.intranet.pajak.go.id/home/en-US/"
#	Then  I enter "wahyu.agungsugimartanto" as userId and "Pajak123" as Password
#	Then  I press Login Button
#	When  I am on page titled "Home"
#	Then  I click on Core Home Menu label "Payment"
#	Then  I click on Core Home SubMenu label "Self-Service Billing Code Creation"
#	When  I am on page titled "Payment"
#	Then  I will perform Self Service Billing with "0729150458413000" on Core Payment page  
#
#
#	
@PaymentCoreTemporary
Scenario: Add Credit for Balance Transfer Request
	Given I navigate to CtasCore at @"https://ctas-mtra.intranet.pajak.go.id/home/en-US/"
	Then  I enter "admin" as userId and "Pajak123" as Password
	Then  I press Login Button
	When  I am on page titled "Home"
	Then  I click on Core Home Menu label "Payment"
	Then  I click on Core Home SubMenu label "Manual Creation of Payments"
	When  I am on page titled "Payment"
	Then  I will perform Manual Creation of Payment with TIN = "1091031210910452" on Core Payment page  
#	