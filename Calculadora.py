# Define a função
def calculate():
    operation = input('''
Escolha uma operação matematica 
+ para adiçao
- para subtracao
* para multiplicacao
/ para divisao
''')

    number_1 = int(input('Digite o primeiro numero: '))
    number_2 = int(input('Digite o segundo numero: '))
# ADICAO
    if operation == '+':
        print('{} + {} = '.format(number_1, number_2))
        print(number_1 + number_2)
# SUBTRACAO
    elif operation == '-':
        print('{} - {} = '.format(number_1, number_2))
        print(number_1 - number_2)
# MULTIPLICACAO
    elif operation == '*':
        print('{} * {} = '.format(number_1, number_2))
        print(number_1 * number_2)
# DIVISAO
    elif operation == '/':
        print('{} / {} = '.format(number_1, number_2))
        print(number_1 / number_2)
# INVALIDO 
    else:
        print('Não foi, copile novamente')


    again()

def again():
    calc_again = input('''
  Voce quer calcular de novo?
DIGITE Y for YES or N for NO.
''')

    if calc_again.upper() == 'Y':
        calculate()
    elif calc_again.upper() == 'N':
        print('See you later.')
    else:
        again()

calculate()