import math

def Point_and_Edge(n, spisok_point): # Запись всех вершин и рёбер в список
    for i in range(0, n):
        print("Укажите длину ребра ")
        edge = int(input())
        print("1-я вершина ребра")
        point1 = str(input())
        print("2-я вершина ребра")
        point2 = str(input())
        spisok_point.append((edge, point1, point2))
    return spisok_point

def Izo(SP, ribs_izo):
    for r in SP:
        if r[1] not in spisok or r[2] not in spisok:
            if r[1] not in spisok and r[2] not in spisok:
                ribs_izo[r[1]] = [r[1], r[2]]
                ribs_izo[r[2]] = ribs_izo[r[1]]
            else:
                if not ribs_izo.get(r[1]):
                    ribs_izo[r[2]].append(r[1])
                    ribs_izo[r[1]] = ribs_izo[r[2]]
                else:
                    ribs_izo[r[1]].append(r[2])
                    ribs_izo[r[2]] = ribs_izo[r[1]]
    ribs.append(r)
    ribs_izo.add(r[1])
    ribs_izo.add(r[2])

def dlina(ribs):
    d = 0
    for i in ribs:
        d += i
    return d

spisok_point = [(math.inf, "-1", "-1")] # Список ребер типо [длина, 1-я вершина, 2-я вершина]

print("Количество вершин")
n = int(input())
Point_and_Edge(n, spisok_point)

sort_point = sorted(spisok_point, key=lambda x: x[0])

spisok = {} # Список соеденёных вершин
ribs_izo = {}
ribs = []

Izo(sort_point, ribs_izo)

for r in sort_point:    # проходим по ребрам второй раз и объединяем разрозненные группы вершин
    if r[2] not in ribs_izo[r[1]]:     # если вершины принадлежат разным группам, то объединяем
        ribs.append(r)             # добавляем ребро в остов
        p = ribs_izo[r[1]]
        ribs_izo[r[1]] += ribs_izo[r[2]]      # объединем списки двух групп вершин
        ribs_izo[r[2]] += p

print(dlina(ribs))