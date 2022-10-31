// Randomly shuffle the elements of the array that's passed in.
function shuffle(array) {
    var swapIndex = array.length;
    var temp, randomIndex;

    while (swapIndex !== 0) {

        randomIndex = Math.floor(Math.random() * swapIndex);

        swapIndex -= 1;

        temp = array[swapIndex];
        array[swapIndex] = array[randomIndex];
        array[randomIndex] = temp;
    }

    return array;
}

// Returns true if array is sorted, false if not.
function isSorted(array){
    for(var i = 1; i < array.length; i++) {
        if (array[i-1] > array[i]) {
            return false;
        }
    }
    return true;
}

// Shuffles array until it's sorted.
function bogoSort(array){
    while(isSorted(array) == false) {
        array = shuffle(array);
    }
    return array;
}

const testValues = [29, 100, 1, 2, 57];

var sorted = bogoSort(testValues);
console.log(sorted);