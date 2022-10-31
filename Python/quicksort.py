import sys
from load import load_numbers

numbers = load_numbers(sys.argv[1])

# We already have the base case written. Any list passed in that consists of 
# zero or one values will be returned as-is, because there's nothing to sort.
def quicksort(values):
  if len(values) <= 1:
    return values
  # Now we need to create a list that will hold all the values less than the
  # pivot. That list will be empty at first.
  less_than_pivot = []
  # We do the same for values greater than the pivot.
  greater_than_pivot = []
  # Next we need to choose the pivot value. For now, we just grab the first
  # item from the list.
  pivot = values[0]
  # Then we loop through all the items in the list following the pivot.
  for value in values[1:]:
    # We check to see whether the current value is less than or equal to the
    # pivot.
    if value <= pivot:
      # If it is, we copy it to the sub-list of values less than the pivot.
      less_than_pivot.append(value)
    # Otherwise, the current value must be greater than the pivot...
    else:
      # So we copy it to the other list.
      greater_than_pivot.append(value)
  # This last line is where the recursive magic happens. We call quicksort
  # recursively on the sub-list that's less than the pivot. We do the same
  # for the sub-list that's greater than the pivot. Those two calls will
  # return sorted lists, so we combine the sorted values less than the pivot,
  # the pivot itself, and the sorted values greater than the pivot. That
  # gives us a complete, sorted list, which we return.
  return quicksort(less_than_pivot) + [pivot] + quicksort(greater_than_pivot)

sorted_numbers = quicksort(numbers)
print(sorted_numbers)