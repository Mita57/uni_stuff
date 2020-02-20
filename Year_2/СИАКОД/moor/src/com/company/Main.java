package com.company;

import java.io.*;

public class Main {
    public static void main(String[] args) throws IOException {
        File file = new File("20k.txt");
        BufferedReader br = new BufferedReader(new FileReader(file));
        String st;
        String pattern = "^.*mor.*$";
        while ((st = br.readLine()) != null) {
            if(st.matches(pattern)) {
                st = st.replaceAll("mor", "moor");
                System.out.print(st.split(" ")[0] + "; ");
            }
        }
    }
}

