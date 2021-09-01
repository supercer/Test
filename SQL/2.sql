
--��������� 2 ������� Brands � Cars � ������� ����������� ���������� �� ������ �������
--���������� ���������� �����  ID ������� Brands � �������� ����� BrandID ������� Cars
--����� ���������� �� ������� Brands.Name
--� ������ ������ ������ ���������� �������� �� ���������� ����� � ������ ������, ������� ������ ���� >3
SELECT Brands.Name  FROM dbo.Brands 
INNER JOIN dbo.Cars
ON dbo.Brands.ID = dbo.Cars.BrandID
GROUP BY dbo.Brands.Name
HAVING COUNT(dbo.Cars.ID) > 3