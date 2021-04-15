import Home from "./components/Home";
import Header from "./components/Header";
import Footer from "./components/Footer";
import EquipmentList from "./components/EquipmentList";
import User from "./components/User";
import CategoryList from "./components/CategoryList";

const appDiv = document.getElementById('app');

export default() => {
 appDiv.innerHTML = Home.Home();
 Header.SetupHeader();
 Footer.SetupFooter();
 Home.NavHome();
 EquipmentList.NavEquipmentList();
 CategoryList.NavCategoryList();
 User.NavSignUp();
 User.NavLogin();
}

//test comment