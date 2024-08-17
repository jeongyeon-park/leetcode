/* Write your T-SQL query statement below */

Select  A.stock_name, B.price - A.price As capital_gain_loss
From (Select SUM(price) As price, stock_name From Stocks Where operation = 'Buy' Group by stock_name) A
Left Outer Join (Select SUM(price) As price, stock_name From Stocks Where operation = 'Sell' Group by stock_name) B
On A.stock_name = B.stock_name