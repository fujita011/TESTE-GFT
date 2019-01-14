
package order;

import java.util.Scanner;
import javax.swing.*;
import javax.swing.JOptionPane;
public class Order {

    
    public static void main(String[] args) {
        Scanner order = new Scanner(System.in);
        String horario = JOptionPane.showInputDialog(null, "Selecione o horário que pedido está sendo feito. 1- Manhã | 2- Noite","Order",JOptionPane.INFORMATION_MESSAGE);
        String entrada,acomp,bebida,sobremesa;
        String carrinho1,carrinho2,carrinho3,carrinho4,carrinho;
        int pedido;
        float horario1 = Float.parseFloat(horario);
        //Variaveis
        
        
        
        if (horario1 == 1){
            JOptionPane.showMessageDialog(null,"Você selecionou manhã!","Order",JOptionPane.INFORMATION_MESSAGE);
            entrada = "Ovos";
            acomp= "Torradas";
            bebida="Café";
            sobremesa="Erro. Não Disponível";
            
            System.out.println("Faça o seu pedido:");
            System.out.println();
            System.out.println("================================");
            System.out.println("1- Entrada:  " +entrada);
            System.out.println("2- Acompanhamentos:  " +acomp);
            System.out.println("3- Bebida:  " +bebida);
            System.out.println("4- Sobremesa:  " +sobremesa);
            System.out.println();
            JOptionPane.showMessageDialog(null, "Verifique o console.");
            System.out.println("Gostaria de entrada? 1- Sim 2-Não");
            System.out.println("=================================");
            pedido = order.nextInt();
            System.out.println("=================================");
            if (pedido == 1){
               JOptionPane.showMessageDialog(null, "Você adicionou "+entrada+" ao seu carrinho!");
               carrinho1 = "Ovos";
               System.out.println("Itens adicionados: " + carrinho1);
               pedido = 0;
            }
            else if(pedido >= 2){
                JOptionPane.showMessageDialog(null, "Você não optou pela entrada.");
                carrinho1 = "";
                System.out.println("Itens adicionados: " + carrinho1);
                pedido = 0;
            }
            //==========================================================
        
            System.out.println("================================");
            System.out.println("2- Acompanhamentos:  " +acomp);
            System.out.println("3- Bebida:  " +bebida);
            System.out.println("4- Sobremesa:  " +sobremesa);
            System.out.println();
            JOptionPane.showMessageDialog(null, "Continue o pedido.");
            System.out.println("Gostaria de Acompanhamentos? 1- Sim 2-Não");
            System.out.println("=================================");
            pedido = order.nextInt();
            System.out.println("=================================");
            if (pedido == 1){
               JOptionPane.showMessageDialog(null, "Você adicionou "+acomp+" ao seu carrinho!");
               carrinho2 = "Torrada";
               System.out.println("Itens adicionados: " + carrinho2);
               pedido = 0;
            }
            else if(pedido >= 2){
                JOptionPane.showMessageDialog(null, "Você não optou pelos acompanhamentos.");
                carrinho2 = "";
                System.out.println("Itens adicionados: " + carrinho2);
                pedido = 0;
            }
            //=============================
            
            System.out.println("================================");
            System.out.println("3- Bebida:  " +bebida);
            System.out.println("4- Sobremesa:  " +sobremesa);
            
            JOptionPane.showMessageDialog(null, "Continue o pedido.");
            System.out.println("Gostaria de bebida? 1- Sim 2-Não");
            System.out.println("=================================");
            pedido = order.nextInt();
            System.out.println("=================================");
            if (pedido == 1){
                String n = JOptionPane.showInputDialog(null, "Quantas bebida gostaria?");
                float n1 = Float.parseFloat(n);
               JOptionPane.showMessageDialog(null, "Você adicionou "+n1+" "+bebida+"(s) ao seu carrinho!");
               carrinho3 = "Café";
               System.out.println("Itens adicionados: "+n1+" " + carrinho3+ "(s)");
               pedido = 0;
            }
            else if(pedido >= 2){
                JOptionPane.showMessageDialog(null, "Você não optou pela bebida.");
                carrinho3 = "";
                System.out.println("Itens adicionados: " + carrinho3);
                pedido = 0;
            }
            //===========================================
            
            
            
            
            
            
            
            JOptionPane.showMessageDialog(null, "Pedido finalizado!");
            //==========================================
            
        }
        else if(horario1 == 2){
            JOptionPane.showMessageDialog(null,"Você selecionou noite!","Order",JOptionPane.INFORMATION_MESSAGE);
            
            entrada = "Beef";
            acomp= "Batatas";
            bebida="Vinho";
            sobremesa="Bolo";
            
            System.out.println("Faça o seu pedido:");
            System.out.println();
            System.out.println("================================");
            System.out.println("1- Entrada:  " +entrada);
            System.out.println("2- Acompanhamentos:  " +acomp);
            System.out.println("3- Bebida:  " +bebida);
            System.out.println("4- Sobremesa:  " +sobremesa);
            System.out.println("=================================");
            JOptionPane.showMessageDialog(null, "Verifique o console.");
            System.out.println("Gostaria de entrada? 1- Sim 2-Não");
            System.out.println("=================================");
            pedido = order.nextInt();
            System.out.println("=================================");
            if (pedido == 1){
               JOptionPane.showMessageDialog(null, "Você adicionou "+entrada+" ao seu carrinho!");
               carrinho1 = "Beef";
               System.out.println("Itens adicionados: " + carrinho1);
               pedido = 0;
            }
            else if(pedido >= 2){
                JOptionPane.showMessageDialog(null, "Você não optou pela entrada.");
                carrinho1 = "";
                System.out.println("Itens adicionados: " + carrinho1);
                pedido = 0;
            }
            //==========================================================
            
            System.out.println("================================");
            System.out.println("2- Acompanhamentos:  " +acomp);
            System.out.println("3- Bebida:  " +bebida);
            System.out.println("4- Sobremesa:  " +sobremesa);
            
            JOptionPane.showMessageDialog(null, "Continue o pedido.");
            System.out.println("Gostaria de Acompanhamentos? 1- Sim 2-Não");
            System.out.println("=================================");
            pedido = order.nextInt();
            System.out.println("=================================");
            if (pedido == 1){
                String n = JOptionPane.showInputDialog(null, "Quantos acompanhamentos gostaria?");
                float n1 = Float.parseFloat(n);
               JOptionPane.showMessageDialog(null, "Você adicionou "+n1+" "+acomp+"(s) ao seu carrinho!");
               carrinho2 = "Batata2";
               System.out.println("Itens adicionados: "+n1+" " + carrinho2+ "(s)");
               pedido = 0;
            }
            else if(pedido >= 2){
                JOptionPane.showMessageDialog(null, "Você não optou pelos acompanhamentos.");
                carrinho2 = "";
                System.out.println("Itens adicionados: " + carrinho2);
                pedido = 0;
            }
            //=============================
            
            System.out.println("================================");
            System.out.println("3- Bebida:  " +bebida);
            System.out.println("4- Sobremesa:  " +sobremesa);
            
            JOptionPane.showMessageDialog(null, "Continue o pedido.");
            System.out.println("Gostaria de bebida? 1- Sim 2-Não");
            System.out.println("=================================");
            pedido = order.nextInt();
            System.out.println("=================================");
            if (pedido == 1){
               JOptionPane.showMessageDialog(null, "Você adicionou "+bebida+" ao seu carrinho!");
               carrinho3 = "Vinho";
               System.out.println("Itens adicionados: " + carrinho3);
               pedido = 0;
            }
            else if(pedido >= 2){
                JOptionPane.showMessageDialog(null, "Você não optou pela bebida.");
                carrinho3 = "";
                System.out.println("Itens adicionados: " + carrinho3);
                pedido = 0;
                 
            }
            //=============================
            
            System.out.println("================================");
            System.out.println("4- Sobremesa:  " +sobremesa);
            
            JOptionPane.showMessageDialog(null, "Continue o pedido.");
            
            System.out.println("Gostaria de sobremesa? 1- Sim 2-Não");
            System.out.println("=================================");
            pedido = order.nextInt();
            System.out.println("=================================");
            if (pedido == 1){
               JOptionPane.showMessageDialog(null, "Você adicionou "+sobremesa+" ao seu carrinho!");
               carrinho4 = "Bolo";
               System.out.println("Itens adicionados: " + carrinho4);
               pedido = 0;
            }
            else if(pedido >= 2){
                JOptionPane.showMessageDialog(null, "Você não optou pela bebida.");
                carrinho4 = "";
                System.out.println("Itens adicionados: " + carrinho4);
                pedido = 0;
            //===========================================
            JOptionPane.showMessageDialog(null, "Pedido finalizado!");
        }
        
        System.exit(0);
    }
    
}
}
