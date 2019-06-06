Delete functionality with stored procedure. 
Before deleting the given customer, in stored precedure is checked if customer has one or more orders. 
If no, delete customer. But, if yes, using RAISERROR function, send notification to the client that customer can't be deleted.
Also return an error if given customer doesn't exists.
