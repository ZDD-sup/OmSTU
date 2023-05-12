import math

def Input_matrix(matrix, N):
    for i in range(0,N):
        stroka = []
        for x in range(0, N):
            a = int(input())
            stroka.append(a)
        matrix.append(stroka)
    return matrix
def arg_min(T, S):
    amin = -1
    m = math.inf  # максимальное значение
    for i, t in enumerate(T):
        if t < m and i not in S:
            m = t
            amin = i
    return amin

N = int(input()) # число вершин в графе

matrix = []

matrix = Input_matrix(matrix, N)

end_str = [math.inf] * N   # последняя строка таблицы

v = 0       # стартовая вершина (нумерация с нуля)
spisok = {v}     # просмотренные вершины
end_str[v] = 0    # нулевой вес для стартовой вершины
min_ribs = [0] * N   # оптимальные связи между вершинами

while v != -1:          # цикл, пока не просмотрим все вершины
    for j, dw in enumerate(matrix[v]):   # перебираем все связанные вершины с вершиной v
        if j not in spisok:           # если вершина еще не просмотрена
            w = end_str[v] + dw
            if w < end_str[j]:
                end_str[j] = w
                min_ribs[j] = v        # связываем вершину j с вершиной v

    v = arg_min(end_str, spisok)            # выбираем следующий узел с наименьшим весом
    if v >= 0:                    # выбрана очередная вершина
        spisok.add(v)                 # добавляем новую вершину в рассмотрение

#print(T, M, sep="\n")

# формирование оптимального маршрута:
start = 0
end = 4
P = [end]
while end != start:
    end = min_ribs[P[-1]]
    P.append(end)

print(P)

