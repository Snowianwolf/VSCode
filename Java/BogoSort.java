import java.util.*;

public class BogoSort {
    public static void main(String[] args) {
        ArrayList<Integer> list = new ArrayList<Integer>(Arrays.asList(29, 100, 1, 2, 57));
        bogoSort(list);
        System.out.println(list);
    }

    static void bogoSort(ArrayList<Integer> list) {
        while(!isSorted(list)) {
            Collections.shuffle(list);
        }
    }

    /**
     * @param list
     * @return
     */
    static boolean isSorted(ArrayList<Integer> list) {
        for(int i=1; i < list.size(); i++) {
            if(list.get(i) < list.get(i-1)) {
                return false;
            }
        }
        return true;
    }
}