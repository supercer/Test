
--��������� 2 ������� Brands � Cars � ������� ����������� ���������� �� ������ �������
--���������� ���������� �����  ID ������� Brands � �������� ����� BrandID ������� Cars
--� ������� ���������� ������� SUMM �� ������� Cars.Price ������� ����� ��� ����������� � ������� ����������� �� ������ 
-- ���������� �� ������� Brands.Name
SELECT Brands.Name, SUM(dbo.Cars.Price) AS SummaPrice FROM dbo.Brands 
INNER JOIN dbo.Cars
ON dbo.Brands.ID = dbo.Cars.BrandID
GROUP BY dbo.Brands.Name