<?php
 
echo "<h2> Livraria </h2>";
 
 
 
function InserirLivros ($nome_do_livro, $data_lancamento, $editora){
  // $conexao chama o nosso banco de dados para o php
  $conexao =  new PDO ("mysql:host=localhost;dbname=tb_livros", "root", "");
 
  $Livros = " INSERT INTO  livros (nome_do_livro, data_lancamento, editora) value (:nome_do_livro, :data_lancamento, :editora)";
 
  $preparacao = $conexao->prepare($Livros);
  $preparacao->bindParam(":nome_do_livro", $nome_do_livro);
  $preparacao->bindParam(":data_lancamento", $data_lancamento);
  $preparacao->bindParam(":editora", $editora);
 
  $preparacao->execute();
 
}
 
 
InserirLivros ($_POST ['nome_do_livro'],$_POST['data_lancamento'],$_POST['editora']);
 

echo $_POST['nome_do_livro']."<br>" ;
echo $_POST['data_lancamento']."<br>";
echo $_POST['editora']."<br>";

 
?>