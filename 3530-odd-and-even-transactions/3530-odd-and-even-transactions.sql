# Write your MySQL query statement below
Select transaction_date, 
        SUM(Case When amount % 2 <> 0  Then amount Else 0 End) As odd_sum,
        SUM(Case When amount % 2 = 0 Then amount Else 0 End) As even_sum
From transactions
Group by transaction_date
Order by transaction_date