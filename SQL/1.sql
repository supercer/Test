

--C ������� ����������� ���������� ������� Cars � ����� ����� ������� ����������� ������ �������� ��������� � �������
SELECT Cars.Name, Cars.BaseID  FROM dbo.Cars 
INNER JOIN dbo.Cars AS c
ON  Cars.BaseID = c.ID AND Cars.BrandID = c.BrandID
