try:
  print("Digite dois valores inteiros")
  x = int(input())
  y = int(input())
  z = x / y
  print(z)
except (ValueError):
  print("Valor informado não é válido")
except (Exception):
  print("Não pode dividir por zero")
print("Cheguei aqui!")