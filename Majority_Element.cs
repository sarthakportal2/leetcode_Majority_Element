public class Solution {
    public int MajorityElement(int[] nums) {
        //min runtime(117 ms)T(C(N)=O(N)) and S(C(N)=O(1)) as it require not memory size allocation iteratively
        int majorelem=nums[0];int cnt=1;//variables declare
        for(int i=1;i<nums.Length;i++){//iterate through nums's size 
            if(nums[i]==majorelem)cnt++;//incrementing count to the matched element 
            else {
                cnt--;//decrementing count 
                if(cnt==0){//initially checking count 
                    majorelem=nums[i];//declaring current number as majorelement 
                    cnt++;//incrementing count 
                }
            }
        }
        return majorelem;//printing Major element output
    }
}
