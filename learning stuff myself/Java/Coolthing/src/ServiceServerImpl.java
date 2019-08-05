import java.rmi.server.UnicastRemoteObject;
import java.rmi.*;
import java.util.*;
import java.rmi.server.*;

public class ServiceServerImpl extends UnicastRemoteObject implements ServiceServer {
    HashMap serviceList;

    public ServiceServerImpl() throws RemoteException{
        setUpServices();
    }

    private void setUpServices(){
        serviceList = new HashMap();
        serviceList.put("Dice Rolling Service", new DiceService());
        serviceList.put("Day of the Week Service", new DiceService());
        serviceList.put("Visual Music Service ", new MiniMusicService());
    }

    public Object[] getServiceList(){
        System.out.println("In remote");
        return serviceList.keySet().toArray();
    }

    public Service getService (Object serviceKey) throws RemoteException{
        Service theService = (Service) serviceList.get(serviceKey);
        return theService;
    }

    public static void main (String[] args){
        try {
            Naming.rebind("ServiceServer", new ServiceServerImpl());
        }
        catch (Exception ex){
            ex.printStackTrace();
        }
            System.out.println("Remote service is running");
    }
}
