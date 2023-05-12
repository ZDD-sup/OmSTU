import math

def Input_matrix(N):
    matrix = []
    for i in range(0,N):
        stroka = []
        for x in range(0, N):
            a = int(input())
            stroka.append(a)
        matrix.append(stroka)
    return matrix
def get_path(P, u, v):
    path = [u]
    while u != v:
        u = P[u][v]
        path.append(u)

    return path

N = int(input()) # число вершин в графе

matrix = Input_matrix(N)

sp = [[v for v in range(N)] for u in range(N)]  # начальный список предыдущих вершин для поиска кратчайших маршрутов

for k in range(N):
    for i in range(N):
        for j in range(N):
            d = matrix[i][k] + matrix[k][j]
            if matrix[i][j] > d:
                matrix[i][j] = d
                sp[i][j] = k     # номер промежуточной вершины при движении от i к j

# нумерацця вершин начинается с нуля
start = 1
end = N
print(get_path(sp, end, start))