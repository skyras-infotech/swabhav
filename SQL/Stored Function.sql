Create function GetEmployeeDetails()      
returns table       
as      
return(select * from EMP)

select * from GetEmployeeDetails()