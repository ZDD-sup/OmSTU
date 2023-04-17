import math

spisok_point = [(math.inf, "-1", "-1")] # Список ребер типо [длина, 1-я вершина, 2-я вершина]

def Point_and_Edge(n, spisok_point): # Запись всех вершин и рёбер в список
    for i in range(0, n):
        point1 = str(input())
        point2 = str(input())
        edge = int(input())
        spisok_point.append((edge, point1, point2))

def egde_min(spisok_point, spisok):
    min = (math.inf, -1, -1)
    for i in spisok:
        m = min(spisok_point, key=lambda x: x[0] if (x[1] == i or x[2] == i) and (x[1] not in spisok or x[2] not in spisok) else math.inf)
        if min[0] > m[0]:
            min = m
    return min

print("Укажите количество вершин")
n = int(input()) # Количество точек

Point_and_Edge(n, spisok_point)

print("Укажите вершину с которой хотите начать")
p = str(input())

spisok = {p} # Список соеденённых вершин
ribs = [] # Список длин рёбер

while len(spisok) < n:
    min = egde_min(spisok_point, spisok)
    if min[0] == math.inf:
        break
    spisok.add(min[1])
    spisok.add(min[2])
    ribs.append(min[0])

def dlina(ribs):
    d = 0
    for i in ribs:
        d += i
    return d

print(dlina(ribs))