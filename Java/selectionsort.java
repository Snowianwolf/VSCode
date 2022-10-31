import java.util.*;

public class Sort {
    /**
     * @param list
     * @return
     */
    static ArrayList<Integer> selectionSort(ArrayList<Integer> list) {
        ArrayList<Integer> sortedList = new ArrayList<Integer>();
        int length = list.size();
        for(int i = 0; i < length; i++) {
            int indexToMove = indexOfMin(list);
            final int min = list.get(indexToMove);
            list.remove(indexToMove);
            sortedList.add(min);
        }
        return sortedList;
    }

    /**
     * @param list
     * @return
     */
    static int indexOfMin(ArrayList<Integer> list) {
        int minIndex = 0;
        int length = list.size();
        for (int i = 0; i < length; i++) {
            if(list.get(i) < list.get(minIndex)) {
                minIndex = i;
            }
        }
        return minIndex;
    }

    public static void main(String[] args) {
        ArrayList<Integer> list = new ArrayList<Integer>(Arrays.asList(29, 100, 1, 2, 57));
        System.out.println(selectionSort(list));
    }
}