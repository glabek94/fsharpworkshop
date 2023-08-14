#load "Types.fs"
#load "Functions.fs"

open Types
open Functions

let customer: Customer = { Id = 1; IsVip = false; Credit = 10M }

let purchases = (customer, 101M)
let vipCustomer = tryPromoteToVip purchases

let calculatedPurchases = getPurchases customer

let customerWithMoreCredit = increaseCreditUsingVip customer

let upgradedCustomer: Customer = upgradeCustomer customer