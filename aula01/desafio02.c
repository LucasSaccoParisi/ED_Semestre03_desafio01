#include<stdio.h>
#include<stdlib.h>

struct no {
    int info;         
    struct no * prox;
};

struct no * novoNo(int info) {
    struct no * novo = malloc(sizeof(struct no));
    novo->info = info;
    return novo;
}

struct no * insert_first(struct no * lista, int info) {
    struct no *novo = novoNo(info);
    if (!novo) return lista;   // se falhar, mantém a lista como estava
    novo->prox = lista;        // novo aponta para a antiga cabeça
    return novo;               // novo vira a cabeça
}

void insert_last(struct no * lista, int info) {
    struct no *novo = novoNo(info);
    // Precisamos encontrar o último elemento da lista. Quando encontramos, adicionamos o novo!
    struct no *curr = lista;
    while (curr->prox != NULL) {
        curr = curr->prox;
    }
    curr->prox = novo;
}

struct no * remove_first(struct no * lista) {
    if (lista == NULL) return NULL; // lista vazia

    struct no *novo_inicio = lista->prox;
    return novo_inicio;
}

struct no * remove_last(struct no * lista){
  if (lista == NULL) return NULL;
  
  struct no *prev = lista;
  struct no *curr = lista->prox;

  while(curr->prox != NULL){
    prev = curr;
    curr = curr->prox;
  }
  prev->prox = NULL;
  free(curr);
  return lista;
}

void print_lista(struct no * lista){
  struct no * curr = lista;
  while (curr != NULL) {
    if (curr->prox != NULL)
      printf("%d...aponta para (%d)\n", curr->info, curr->prox->info);
    else
      printf("%d\n", curr->info);
    
    curr = curr->prox;
  }
}

int main() {
    struct no * lista = novoNo(1);

    insert_last(lista, 2);
    insert_last(lista, 4);
    insert_last(lista, 6);
    insert_last(lista, 8);
    insert_last(lista, 10);

    print_lista(lista);
    
    printf("\n ------------ \n");

    remove_last(lista);
    printf("\n");

    print_lista(lista);

    return 0;
}
