function indexOfItem(collection, target) {
    var first = 0;
    var last = collection.length - 1;
    while (first <= last) {
        midpoint = Math.floor((first + last) / 2);
        if (collection[midpoint] === target) {
            return midpoint;
        } else if (collection[midpoint] < target) {
            first = midpoint + 1;
        } else {
            last = midpoint - 1;
        }
    }
    return null;
}

// Note that this array is now sorted!
const names = ["Elida Sleight", "Francina Vigneault", "Lucie Hansman", "Nancie Rubalcaba"];

var index = indexOfItem(names, "Lucie Hansman");
console.log(index);