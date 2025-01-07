from IEmployee import IEmployee

class HumanResources(IEmployee):
    def __init__(self, deneme):
        self.deneme = deneme  
        self.employee_list = [] 

    def add_employee(self, employee):
        self.employee_list.append(employee)

    def remove_employee(self, employee):
        self.employee_list.remove(employee)

    def show_info(self):
        print(self.deneme)
        for employee in self.employee_list:
            employee.show_info()