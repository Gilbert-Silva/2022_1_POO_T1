def menor_valor(a, b):
    menor = a
    if b < menor: menor = b
    return menor

def menor_valor2(a, b, c):
    menor = a
    if b < menor: menor = b
    if c < menor: menor = c
    return menor

x = menor_valor2(10, 3, 4)
print(x)
x = menor_valor(10, 3)
print(x)
