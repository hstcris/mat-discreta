tarefas = []
# loop para ser executado até o usuario pedir para sair 
while True:
  # exibe a lista de tarefas enumerada
    print("Lista de Tarefas:")
    for i, tarefa in enumerate(tarefas, start=1):
        print(f"{i}. {tarefa}")
# exibe as opções
    print("\nEscolha uma opção:")
    print("1. Adicionar Tarefa")
    print("2. Remover Tarefa")
    print("3. Sair")
  # solicita ao usuario que digite a opção desejada 

    escolha = input("Digite o número da opção desejada: ")

   
