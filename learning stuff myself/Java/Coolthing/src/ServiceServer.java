import java.rmi.*;
import java.security.Provider;
public interface ServiceServer extends Remote{
    Object[] getServiceList() throws RemoteException;
    Service getService(Object serviceKey) throws RemoteException;
}
