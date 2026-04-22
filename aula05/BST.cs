// BST é Binary Search Tree
public class BST {
  private Node Raiz { get; set; }

  public BST(){
    this.Raiz = null;
  }

  public Node insert(Node raiz, int valor){
    if(raiz == null)
      return new Node(valor);
    
    if (valor > raiz.Key)
      raiz.Right = this.insert(raiz.Right, valor);
    else
      raiz.Left = this.insert(raiz.Left, valor);

    return raiz;
  }

  public Node Search(Node raiz, int alvo){
    if (raiz == null)
      return null;
    
    if (raiz.Key == alvo)
      return raiz;
    
    if (raiz.Key > alvo)
      return this.Search(raiz.Left, alvo);
    else
      return this.Search(raiz.Right, alvo);
  }
}
