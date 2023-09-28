def calculadora_media():
  #pede os valores de entrada; quantos numeros quer calcular

    n = int(input("Quantos números você deseja calcular a média? "))
    numeros = []

    for i in range(n): #pede os valores desses numeros
        numero = float(input(f"Digite o número {i + 1}: "))
        numeros.append(numero)

    media = sum(numeros) / n #saida dos valores; media 
    print(f"A média dos números é: {media:.2f}")

calculadora_media()
