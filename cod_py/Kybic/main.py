from math import ceil

num = "1"
N, M = map(int, open("D:/Python/Test/input_s1_01.txt").readlines()[0].split())
XN, YN, ZN = map(int, open("D:/Python/Test/input_s1_01.txt").readlines()[1].split())

def spin(c, let, cwi):
	cwi = int(cwi) 
	if let == "X":
		if cwi == 1:
			return [c[0], c[2], -c[1]]
		else:
			return [c[0], -c[2], c[1]]
	if let == "Y":
		if cwi == -1: 
			return [-c[2], c[1], c[0]]
		else:
			return [c[2], c[1], -c[0]]
	if let == "Z":
		if cwi == 1:
			return [c[1], -c[0], c[2]]
		else:
			return [-c[1], c[0], c[2]]

XN, YN, ZN = XN - 0.5, YN - 0.5, ZN - 0.5

A = [XN - (N / 2), YN - (N / 2), ZN - (N / 2)]

for i in open("D:/Python/Test/input_s1_01.txt").readlines()[2:]:
	j = int(i.split()[1]) - 0.5 - N/2
	if i.split()[0] == "X":
		if j == A[0]:
			A = spin(A, "X", i.split()[2])
	if i.split()[0] == "Y":
		if j == A[1]:
			A = spin(A, "Y", i.split()[2])
	if i.split()[0] == "Z":
		if j == A[2]:
			A = spin(A, "Z", i.split()[2])

print(*[int(i + N/2 + 0.5) for i in A])