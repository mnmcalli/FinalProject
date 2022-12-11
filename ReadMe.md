# CIT24200 Final Project

This final project was made for CIT24200 at IUPUI. This is a simple program that uses MVC structure to connect web pages to C# files, which provide connectivity to a database. This is meant to be a proof of concept, satisfying the criteria for the assignment. This file will reference FinalProjectVisual.pdf.


## Intent

This program is meant to use the MVC stucture and razor pages to provide functionality to update the bank.db database. Originally, I had planned for a much larger scope than I wound up having time for. For this particular project, we assume the user is already logged in, and we provide withdrawal functionality. Depositing functionality can be looked into at a later date. Originally, transferring money between accounts and creating accounts were going to be part of the functionality, but those, as well as the calculation of interest were practically dropped for this project. The multiple types of accounts were also dropped.

This means that there is one type of user, that can access their account (we assume that one user has one, and only one account) and withdraw money from it. There is, as I mentioned, only one type of account.

## Functionality

The website should open to a homepage that allows navigation to a Withdrawal Page (as seen in the pdf). The controller then routes to the withdrawal page, which displays a box (for the amount to withdraw) and a submit button. This is as far as I got successfully, and I couldn't test any further due to syntax errors.

The following is implemented unsuccessfully:

Upon pressing submit, the Withdraw webpage should push the amount back to controller, which should then use "withdraw()," which I had intended to have route back to the Account.withdraw() method. The controller should have unit testing within its withdraw method.
Next, the database manager (DBManager) should save the new balance to the database. Finally, there should be some sort of confirmation page to let the user know that their action has been completed.

## Notes

I did my best to provide as much functionality as I could, even where I wasn't sure of the exact syntax to use. There are portions of this code that are more akin to pseudocode than anything functional, but I hope that this demonstrates, at least, that I have an understanding of what can be accomplished, and that I understand what needs to happen within each file, even if I don't know the code or syntax to make it happen myself.
