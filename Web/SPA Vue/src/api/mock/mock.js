import axios from "axios";
import {userController} from "@/api/mock/user-controller";



async function testApi() {
  // Get the access token from the auth wrapper
  console.log(this.$auth)
  const token = await this.$auth.getTokenSilently();
  console.log(token)

  // Use Axios to make a call to the API
  const {data} = await axios.get(
    "https://localhost:5001/api/test/welcomeadmin",
    {
      headers: {
        Authorization: `Bearer ${token}` // send the access token through the 'Authorization' header
      }
    }
  );
  console.log(data);
  return data;
}


export const mockApi = {
  ...userController,
  testApi
};
